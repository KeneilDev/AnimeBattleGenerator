##############################
## Azure App Service - Main ##
##############################

# Create a Resource Group
resource "azurerm_resource_group" "appservice-rg" {
  name     = "keneil-app-service-rg"
  location = var.location

  tags = {
    description = var.description
    environment = var.environment
    owner       = var.owner  
  }
}

# Create the App Service Plan
resource "azurerm_app_service_plan" "service-plan" {
  name                = "keneil-service-plan"
  location            = azurerm_resource_group.appservice-rg.location
  resource_group_name = azurerm_resource_group.appservice-rg.name
  kind                = "Windows"
  reserved            = false

  sku {
    tier = "Basic"
    size = "B1"
  }

  tags = {
    description = var.description
    environment = var.environment
    owner       = var.owner  
  }
}

# Create the App Service
resource "azurerm_app_service" "app-service" {
  for_each = var.services
  name = each.value.name
  location            = azurerm_resource_group.appservice-rg.location
  resource_group_name = azurerm_resource_group.appservice-rg.name
  app_service_plan_id = azurerm_app_service_plan.service-plan.id

  site_config {
    dotnet_framework_version = "v5.0"
  }

  tags = {
    description = var.description
    environment = var.environment
    owner       = var.owner  
  }
}