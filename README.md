<!-- default badges list -->
Automatically generated badges
<!-- default badges end -->

# Reporting for WinForms - Display Average Values within a Chart

The following example displays a constant line (average product price) for a given product category (when using DevExpress Reports for WinForms).

![XRCharts](Images/xrchart.png)

In this example, the chart’s constant line is bound to the following expression:

```expression
[CategoriesProducts].Avg([UnitPrice])
```

![Expression Editor](Images/expression-editor.png)

## Documentation

* [Bind Report Controls to Data with Binding Expressions](https://docs.devexpress.com/XtraReports/1180/detailed-guide-to-devexpress-reporting/use-report-controls/bind-report-controls-to-data/specify-a-control-s-binding-expression?v=23.1)
