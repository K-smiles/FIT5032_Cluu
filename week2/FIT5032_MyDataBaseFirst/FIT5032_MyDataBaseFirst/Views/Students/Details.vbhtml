﻿@ModelType FIT5032_MyDataBaseFirst.Student
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Student</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FirstName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastName)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
