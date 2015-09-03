# Sitecore Social Networks

This is a Sitecore module that attempts to support several points of integration with various social networks.

## Rendering Support

All renderings are implemented using MVC.  Respective .cshtml files are all stored within /Areas/GnosisSocialNetworks/Views.

## Twitter Cards

See the Twitter's own documentation:
https://dev.twitter.com/cards/overview

I have attempted to arrange the fields outlined in the documentation to the specific templates and renderings.  See the spreadsheet "Twitter Card Field Matrix" within the "doc" directory for which fields are used with which card type.

### Usage

#### Stand-Alone Items

Create a folder from the template "/templates/GnosisSocialNetworks/Data Templates/Twitter/Twitter Cards Folder".  By default, the insert options for that item will be the following:

* Twitter Summary Card
* Twitter Summary Card with Large Image
* Twitter App Card
* Twitter Player Card

#### Base Templates

If you would rather add the necessary fields to existing templates, you can elect to inherit from one of the templates in the directory "/templates/GnosisSocialNetworks/Base Templates/Twitter":

* Twitter Summary Card Base
* Twitter Summary Card with Large Image Base
* Twitter App Card Base
* Twitter Player Card Base

#### Renderings

There are four MVC view renderings available, one for each card type.  The related Sitecore items are all under the path "/layout/Renderings/GnosisSocialNetworks/Twitter":

* Twitter Summary Card
* Twitter Summary Card with Large Image
* Twitter App Card
* Twitter Player Card

For each rendering, they will only accept items inherited from the respective base template as a data source.

If you know you only ever be using one rendering for a given layout, you can use the @Html.Sitecore().Rendering("/sitecore/path") method to embed.  Otherwise, assign the necessary rendering to a placeholder.  In either case, the rendering should be called from within the HEAD tag of you page.
