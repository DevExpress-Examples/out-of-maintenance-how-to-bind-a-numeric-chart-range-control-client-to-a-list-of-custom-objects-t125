<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/NumericChartClient/Form1.cs) (VB: [Form1.vb](./VB/NumericChartClient/Form1.vb))
<!-- default file list end -->
# How to bind a numeric chart range control client to a list of custom objects


This example shows how to bind a numeric chart range control client to a <strong>System.Collections.Generic.List</strong> containing <strong>NumericItem</strong> objects.<br /><br />In order to provide data to a chart numeric range control client, you need to access the<strong> ChartRangeControlClientDataProvider </strong>object using the <strong>ChartRangeControlClientBase.DataProvider</strong> property and assign a data source to the <strong>ChartRangeControlClientDataProvider.DataSource </strong>property.<br /><br />Each <strong>NumericItem </strong>object contains <strong>Argument,</strong>  <strong>Value and Series </strong>properties, to which a numeric chart range control client is bound via its <strong>ChartRangeControlClientDataProvider.ArgumentDataMember</strong>, <strong>ChartRangeControlClientDataProvider.ValueDataMember,</strong> and <strong>ChartRangeControlClientDataProvider.SeriesDataMember </strong>(optional) properties. <br /><br />In addition, this example shows how to customize chart client common settings (e.g., change the numeric range, customize template view and grid options).

<br/>


