

# Developer Environment (.NET)

## Overview
In this lab, you will set up an Office365 trial subscription, an Azure trial subscription, configure your Azure subscription for the DevCamp, and provision 
a virtual machine in the subscription to use for development of further labs.

## Objectives
In this hands-on lab, you will set up an Office365 developer subscription, and Azure trial subscription, and an Azure-based virtual machine for the development environment for subsequent labs in the DevCamp.  To expedite the process, we've prepared a Windows image that you will copy into your own environment, start the virtual machine and connect to it.  You will then configure the components for Azure development.
* Set up an Office365 trial subscription
* Set up an Azure trial subscription
* Configure your Azure subscription for DevCamp
* Create an Azure Virtual Machine for remote development
* Connect to the Azure Virtual Machine and configure it for development
* Review the features of the Azure Portal

## Prerequisites

You will need a cell phone and credit card for identity verification.  The credit card ***will not*** be charged unless you remove the spending limit on the subscription you will create.

## Exercises
This hands-on-lab has the following exercises:
* Exercise 1: Set up Office 365 trial subscription
* Exercise 2: Set up Azure trial subscription
* Exercise 3: Start your VSTS trial subscription
* Exercise 4: Configure your Azure subscription for DevCamp
* Exercise 5: Use an Azure Virtual Machine for remote development
* Exercise 6: Deploy Shared API application
* Exercise 7: Azure Portal walkthrough
* Exercise 8: View the resources you created

---
## Exercise 1: Set up Office 365 trial subscription

> If you already have an Office 365 subscription, please use an alternate browser or use private mode. This will help avoid any issues with conflicting accounts.

1. In your browser, go to [https://products.office.com/en-us/business/office-365-enterprise-e3-business-software]() 
and click the link that says `Free Trial`. This will navigate you to this page:

    ![image](./media/2016-10-14_18-59-56.gif)

1. Enter the information requested, and click `Just one more step` which 
    will take you to the following page:
    
    ![image](./media/2016-10-14_19-06-31.gif)

1. Choose a `user id` and a `tenant name` for your trial.  In this case I chose `devcampross`, but you 
    can choose anything you'd like, as long as it is unique.  You'll also have to choose 
    a password, and click `Create my account`.
    
1. Next you will see this page, which asks for phone verification:

    ![image](./media/2016-10-14_19-07-30.gif)

1. After this process is complete, your O365 trial will be set up, and you'll see this page:
    
    ![image](./media/2016-10-18_12-39-13.gif)

    > Make note of your user id, which will be used to sign onto the Azure portal later.

1. Click `You're ready to go`, which will take you to the following screen:

    ![image](./media/2016-10-18_12-42-47.gif)

1. Click on the `admin` app icon, which will open the Office365 admin center page
    in your browser.  It will look like this:

    ![image](./media/2016-10-14_18-38-17.gif)

     If you'd like to see the welcome tour click `Next`, or simply close the dialog box.   
    
> Stay on this page until the next exercise.

---
## Exercise 2: Set up Azure trial subscription

1.  Next, we want to set up an Azure subscription, which can be accessed via the Azure Active Directory link.  On the bottom, left-hand side of the screen, click `Admin centers`, and then click `Azure AD`. 

    ![image](./media/image-015.gif)    
    
    This will open up a new browser tab showing this page:

    ![image](./media/2016-10-14_21-41-33.gif)

> BEGIN Steps for Azure Pass redemption - Follow this step if you are using an Azure Pass.

1. Navigate to [http://www.microsoftazurepass.com/]().

    ![image](./media/image-018.gif)

1. Enter the code that is provided by your facilitator into the text box, then click submit

> END Steps for Azure Pass redemption

1. Click on the `Azure subscription` link. This will will take you to the page for creating a new trial subscription:

    ![image](./media/2016-10-18_12-48-52.gif)

1. Enter the requested information and click `Next`.

1. Enter the information about you, and verify your identity by phone.  Also you will need to verify via credit card.  Your credit card ***will not*** be charged unless you remove the spending cap from your subscription.
    
    ![image](./media/2016-10-14_21-42-46.gif)

1. Finally after the verification process, you'll have to agree to the terms of the trial subscription: 

    ![image](./media/2016-10-14_21-44-53.gif)

1. It will take a few moments to set up your azure subscription.  

    ![image](./media/2016-10-14_21-45-32.gif)

1. When the subscription set up process is complete, you can click on `Start managing my service` to open the Azure portal, which will look like this:

    ![image](./media/2016-10-14_18-00-54.gif)

---
## Exercise 3: Start your VSTS trial subscription

1. In your browser, go to <a href="http://www.visualstudio.com/team-services" target="_blank">http://www.visualstudio.com/team-services</a> and click on `sign in` in the upper right corner.  This should take you to a screen that looks like this:

    ![image](./media/2016-10-18_17-30-18.gif)

1. click on `Use your benefits`, and this window will pop up:

    ![image](./media/2016-10-18_17-42-01.gif)

1. Click Accept to access your Visual Studio Dev Essentials benefits.

---
## Exercise 4: Configure your Azure subscription for DevCamp

1. We have created an Azure Resource Group template that will configure the resources you need in Azure for the DevCamp.  To deploy 
these resources in your Azure subscription, `control + click` on the blue **Deploy to Azure** button below:

    <a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzureCAT-GSI%2FDevCamp%2Fmaster%2FShared%2FARMTemplate%2FAzureDeploy.json" target="_blank">
        <img src="http://azuredeploy.net/deploybutton.png"/>
    </a>

1. You should see a new tab open in your browser and open the Azure portal, with a blade that looks like this:

    ![image](./media/2016-10-18_13-13-25.gif)

1.  Name your resource group `DevCamp`, and choose a location for your deployment. 

    > Please **DO NOT** choose the any of following regions for your deployment (as of January 24, 2017)
    > * US Gov
    > * West India

1. Check the box that indicates you agree to the terms and conditions, and click the `Purchase` button.

    The Resource Group template will start deploying, and the portal will pin a tile to the dashboard showing the status:

    ![image](./media/2016-10-18_13-19-01.gif)

1. This will take approximately 20-30 minutes to complete. Please don't continue on until the template has completed.  While it is working, it is useful to understand what this process is doing.
    In a later session, we will take a look at Azure Resource Group templates, and how to manage your infrastructure the same way 
    you manage your code.  As a short introduction, a template is a JSON file that contains definitions for the resources you want in your
    resource group.  When you apply the resource group template, Azure will apply the template to your Azure resource group, and create 
    the resources you have specified in the template.  This makes it easy to maintain the infrastructure definition in the JSON text file.
    
    In the resource group template we have created for DevCamp, there are several types of resources including Web Apps and a Virtual Machine. The 
    complete list of resources deployed is detailed in Exercise 8 of this Hands-On-Lab.  Resource Group Templates are usually fairly quick to
    apply - the reason this one takes so long is that we are creating a Windows Virtual machine and installing all the tools you will
    need for the DevCamp including Visual Studio, the Java development kit, and other software resources.

    When the Resource Group creation is done, go visit the resource group by clicking `resource groups` on the left navigation pane:

    ![image](./media/2016-10-18_13-36-29.gif) 

1. Then click on your Resource group

    ![image](./media/2016-10-18_13-39-10.gif)

---

## Exercise 5: Use an Azure Virtual Machine for remote development

1. The Azure resource group template will have created a virtual machine that can be used for remote development on Windows. Exercise 6 describes the configuration for the Windows virtual machine, which would be appropriate for any of the languages.

1. In the DevCamp resource group, select the DevCamp DevTest Lab.

    ![image](./media/image-007.gif)

1. Find the Windows virtual machine in your DevTest lab. The name will start with the prefix `windev`:

    ![image](./media/2016-10-18_15-32-30.gif)

1. Select the machine name and open the virtual machine blade  then click `Connect` to connect to the machine using Remote Desktop:

    ![image](./media/image-008.gif)

    This will download a remote desktop connection file, and when you open it, remote desktop on your local machine will attempt to attach to your virtual machine.   When the windows security dialog pops up, click on the `more choices link`, then choose `use a different account`
    
    ![image](./media/2016-10-19_14-42-16.gif)

1. Use the following credentials to log on to the machine:
    
    > User Name = `\l-admin`
    >
    > Password = `Devc@mp2016!` 
 
    ![image](./media/image-009.gif)

    > It would be wise to change the password in the virtual machine.

1. When remote desktop is connected, you will see server manager initially.  We will want to turn of IE enhanced security, to make accessing the web within the virtual machine easier.  First click `local server`;

    ![image](./media/2016-10-18_16-46-33.gif)

1. Then click the `on` next to 

    ![image](./media/2016-10-18_16-50-50.gif)

    A dialog box pops up - choose to turn enhanced security off for administrators.

1. We are going to use git to clone the DevCamp github repository to this development machine. Click on the Start menu, and type `cmd`

    > NOTE: On some high resolution monitors (HIGH DPI), you will notice that the icons and command line windows appear small. If this is an issue, you can download [Remote Desktop Connection Manager 2.7](https://www.microsoft.com/en-us/download/details.aspx?id=44989)

1. Change directory to the root using `cd c:\`

1. Type `git clone https://github.com/AzureCAT-GSI/DevCamp.git` :

    ![image](./media/2016-10-18_17-03-51.gif)

    All of the content for this DevCamp will now be located in `c:\DevCamp\`.

1. Start Visual Studio using the `Visual Studio 2015` shortcut.

    > Note, there are 2 Visual Studio shortcuts. Make sure you **DO NOT** use the "start experimental instance of visual studio 2015" shortcut.

    ![image](./media/image-010.gif)

1. On the sign in screen, click `sign in`. Use the credentials you used earlier for your Office 365 trial subscription.

    > Depending on the version of the Windows image and Visual Studio, your start experience may vary:

    ![image](./media/image-011.gif)
    
    OR
    
    ![image](./media/2016-10-18_17-59-21.gif)
    
1. Create a VSTS repository. Enter a repository name and click continue:

    ![image](./media/2016-10-18_18-07-34.gif)

1. Create your first team project, and name it `DevCamp`:

    ![image](./media/2016-10-18_18-10-39.gif)

1. Click close. You are done with the Visual Studio setup.

----

## Exercise 6: Deploy shared API application ##

1. Open a browser and navigate to [https://portal.azure.com](https://portal.azure.com) Locate the app service named `incidentapi....` in the resource group blade:
    
    ![image](./media/2016-11-14_12-00-24.gif)

1. Click on the app service, which will bring up the app service blade.  Click on `Browse` at the top:

    ![image](./media/2016-11-14_12-02-26.gif)

    A new browser tab will open.

    >
    > If the page looks like the image displayed below, this means the API was automatically deployed from GitHub, and you can skip the rest of this exercise.
    >
    
    ![image](./media/2016-11-14_12-10-59.gif)

    >
    > If the page looks like the image below, continue with this exercise
    >
         
    ![image](./media/2016-11-14_12-03-50.gif)

1. In the Azure portal, select the API Application (noted with the ![image](./media/image-024.gif) icon)
    
    ![image](./media/image-019.gif)

1.	Select deployment options
 
    ![image](./media/image-020.gif)

1.	If the app deployment is connected, click disconnect
 
    ![image](./media/image-021.gif)

1.	Select setup
 
    ![image](./media/image-022.gif)

1.	Select external repository. 

1. Paste the following in the Repository URL field `https://github.com/AzureCAT-GSI/DevCamp.git`

    ![image](./media/image-023.gif)

1.	Select OK

---
## Exercise 7: Azure Portal walkthrough

1. On your local machine or the virtual machine in Azure, open a browser window and go to the main Azure portal page, [http://portal.azure.com](https://portal.azure.com).  Log in with the credentials you supplied in the subscription signup exercise.  You should see the Azure portal, similar to this:

    ![image](./media/2016-10-19_15-08-26.gif)

    There is a lot to notice on this screen.  At the upper left corner, the icon under the `Microsoft Azure` banner allows you to shrink and expand the left bar:

    ![image](./media/2016-10-19_15-15-50.gif)

    Under that, clicking on the `+ New` item will allow you to create new deployments, virtual machines, databases, etc:

    ![image](./media/2016-10-19_15-15-50.gif)
    
1. On the left you will see a list of the Azure services that you can use on the left hand side.  Notice that this list will scroll up and down to reveal more services, and finally an item that says `More Services >`:

    ![image](./media/2016-10-19_15-10-45.gif)

    You can click on any of these and see what items are deployed, and easily create new deployments.

    At the top of the window you have a search box where you can search for any resources:

    ![image](./media/2016-10-19_15-22-14.gif)

1. The bell icon is for notifications, and in this screenshot, it indicates that there are two notifications pending: 

    ![image](./media/2016-10-19_15-22-14a.gif)

    Clicking on the bell will show you the notifications:

    ![image](./media/2016-10-19_15-49-23.gif)

    If you click on one of the notifications, you can go to the list of 
    all current notifications:

    ![images](./media/2016-10-19_15-51-02.gif)

1. The gear at the top of the screen lets you set the color palate for the portal, whether or not there will be animations, and other options for the portal itself:

    ![image](./media/2016-10-19_15-22-14b.gif)

1. The "smiley face" button allows you to send feedback to Microsoft:

    ![image](./media/2016-10-19_15-22-14b.gif)

    Clicking on the icon will give you a form to let us know about your experience:

    ![image](./media/2016-10-19_15-54-02.gif)

1. The Question icon will give you the ability to enter a support case, manage support requests, or get further information on Azure.
    
    ![image](./media/2016-10-19_15-22-14d.gif)

1. Your login name and company name on the upper left hand corner has two functions: 

    ![image](./media/2016-10-19_15-22-14e.gif)
    
    If you hover the mouse over your name, you'll get information about your login, the directory and subscription:

    ![image](./media/2016-10-19_16-25-54.gif)

    If you click on your name, you can sign out, change your password, view your permissions, and view your bill:

    ![image](./media/2016-10-19_16-28-33.gif)

1. Next we will look at the resource group we set up with the template.  Click on `Resource Groups` on the left hand side:

    ![image](./media/2016-10-19_16-30-19.gif)

1. Click on the resource group that you created:

    ![image](./media/2016-10-19_16-32-12.gif)

    A new blade will open with the overview of all of the contents of the resource group listed:

    ![image](./media/2016-10-19_16-33-39.gif)

    You can click on any of the items on the left hand side which will view or manipulate settings for the resource group as a whole.  If you click on any of the individual resources in the center, you will get more information on that resource.

1. Azure automatically logs changes to resource group and who made those changes.  Clicking `Activity log` on the left of the blade will allow you to query the log, and clicking on any logged items will give you additional information on that entry:

    ![image](./media/2016-10-19_16-40-00.gif)

1. Clicking on `Automation script` will allow you to view, edit or download the resource group template that would create this resource group.

    ![image](./media/2016-10-19_16-44-51.gif)

1. The Windows VM is managed by an [Azure DevTest lab](https://azure.microsoft.com/en-us/services/devtest-lab/) named `DevCamp` which handles the startup and shutdown of the machine. To change the start up schedule, click on the DevTest Lab icon and select `Policy Settings`

    ![image](./media/image-012.gif)

1. Select `Auto-shutdown`

    ![image](./media/image-013.gif)

1. Modify the Auto-shutdown schedule based on your time zone

    ![image](./media/image-014.gif)

1. The machine does not automatically turn on. To enable this, in the Policy Settings blade, select `Auto-Start`

    ![image](./media/image-016.gif)

1. Change the schedule based on your time zone.

    ![image](./media/image-017.gif)

> It is particularly useful to create resources in the Azure portal, then save or edit the resource group template.  Resource group templates will be explained further in a later lab.

---
## Exercise 8: View the resources you created

Going back to the list of resources in the resource group, we'll go through the list of each resource, with a description.  Feel free to click on the resource and view its detail blade.

![image](./media/2016-10-19_17-13-01.gif)

Also, our resource group template has added a random string to the end of many of the resources.  In this description, we'll replace that string with .... (order of resources may vary)

1. `incidentcache....:`  This is the Redis cache that we use from the application to make data access faster.  The modern-cloud-apps hands on lab adds support to the application to be able to leverage the cache.

1. ` DevCamp` This is the DevTest lab that is used to manage the VM images and artifacts

1. `incidentdb....:` This is the documentDB database that will hold the JSON incident documents stored by the application.

1. ` DevCamp....` This is the Azure Key Vault that is used to manage secure credentials

1. `DevCampVnet:`  This is an Azure Virtual Network, which will allow components of the resource group to communicate as they were on the same physical network.

1. `addevcamp....:` Storage account for storing artifacts for the DevTest labs.

1. `ddevcamp....:` Storage account for storing the VHDs for images used the DevTest labs..

1. `dpdevcamp....:` Storage account for storing for VHDs for the machines DevTest labs..

1. `incidentblobstg....:` Storage account for storing the uploaded images and the Azure Queue, from the modern-cloud-apps lab.

1. `incidentdiagstg....:` Storage account for storing diagnostics from the services in the resource group.

1. `incidentappplan....:` App Service Plan, which defines how the app services in the resource group will be configured.

1. `dotnetapp....:` App service for running the .NET application when deployed to the cloud.  If you are not using .NET in the labs, you can safely delete this.

1. `incidentapi.....:` App service for running the API service that provides a REST API to the web applications.

1. `javaapp....:` App service for running the Java application when deployed to the cloud.  If you are not using Java in the labs, you can safely delete this.

1. `nodejsapp....:` App service for running the Node.js application when deployed to the cloud.  If you are not using Node.js in the labs, you can safely delete this.

    In the second Resource group, there additional resources created

   ![image](./media/image-026.gif)

   ![image](./media/image-025.gif)

1. `windev....:` This is the Windows server virtual machine that we are using as a development machine for these hands-on-labs. You can delete this machine after the developer-environment lab if you are using an on-premises/local machine for development. 

1. `WindowsDevPip:`  This is a public IP that will allow the Windows development virtual machine to communicate with the Internet (eg. via Remote Desktop).  If you delete the Windows virtual machine, you can safely delete this.

1. `windev...NetworkInterface:`  This is a public network interface that will allow the Windows development virtual machine to communicate on the network.  If you delete the Windows virtual machine, you can safely delete this.

---
## Clean Up

> Please refer back to this section after the DevCamp concludes

To clean up a Resource Group, we typically simply delete the Resource Group. However, since we are using an Azure DevTest Lab to manage our Virtual Machine, we have an additional step.

Azure DevTest Labs create a series of [Resource Locks](https://docs.microsoft.com/en-us/azure/azure-resource-manager/resource-group-lock-resources) that prevent accidental deletion of resources. Locks allow us to safeguard against accidental deletion of critical resources, and to delete the Resource Group we first need to delete the locks.

Open your DevCamp Resource Group, and in the navigation pane select **Locks**. You should see the 5 locks created by the DevTest Lab. To delete, select the three dots to the right of the Notes column, and select **Delete**.

![image](./media/image-027.png)

After all 5 locks have been deleted you are able to delete the resource group. Navigate to the **Overview** tab and select **Delete**. The Resource Group will take several minutes to remove, but when finished all resources will no longer accrue charges in your subscription.

![image](./media/image-028.png)

---
# Summary

In this hands-on lab, you learned how to:
* Set up an Office365 developer subscription
* Set up an Azure trial subscription
* Configure your Azure subscription for DevCamp
* Create an Azure Virtual Machine for development
* Connect to the Azure Virtual Machine and configure it for development
* Use the Azure portal to view the resources that you created

After completing this module, you can continue on to Module 2: Building modern cloud apps

### View Module 2 instructions for [.NET](../../../HOL/dotnet/02-modern-cloud-apps) 

---
Copyright 2016 Microsoft Corporation. All rights reserved. Except where otherwise noted, these materials are licensed under the terms of the MIT License. You may use them according to the license as is most appropriate for your project. The terms of this license can be found at https://opensource.org/licenses/MIT.
