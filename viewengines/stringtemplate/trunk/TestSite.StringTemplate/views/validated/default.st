<html>
	<head>
		<title>Validation Test</title>
		$ValidationHelper/InstallScripts()$
		$ValidationHelper/SetSubmitOptions(confirm=true, disable=true, groupError=false, errorMode=0)$
	</head>
	<body>
		<form method="post" id="demoForm" action="validate.rails" onsubmit="$ValidationHelper/GetValidationTriggerFunction()$">
			<div>
				<fieldset>
					<legend>Basic stuff</legend>
					<label for="Name">Name</label>
					<input type="text" name="Name" id="Name" validators="blank" />
					<label for="Password">Password</label>
					<input type="password" name="Password" id="Password" validators="length|6" />
					<label for="Email">Email</label>
					<input type="text" name="Email" id="Email" validators="email|3" />
					<label for="Email_Confirm">Email Confirm</label>
					<input type="text" name="Email_Confirm" id="Email_Confirm" validators="equalto|Email" />
				</fieldset>
				<fieldset>
					<legend>Logical test (all or none)</legend>
					<label for="Business_Name">Business Name</label>
					<input type="text" name="Business_Name" id="Business_Name" displayName="A Business Custom Name for a Business Man" validators="blank|bok" />
					<label for="Business_Phone">Business Phone</label>
					<input type="text" name="Business_Phone" id="Business_Phone" validators="phone|bok" />
					<label for="Business_Address">Business Address</label>
					<input type="text" name="Business_Address" id="Business_Address" validators="length|10|bok" />
					<input type="hidden" name="Business_Info" validators="allornone|,|Business_Name,Business_Phone,Business_Address" />
				</fieldset>
			</div>
			<div>
				<fieldset>
					<legend>Complex Date checking</legend>
					<label for="Date_1">Date 1</label>
					<input type="text" name="Date_1" id="Date_1" validators="date|mm/dd/yyyy|/|1|today" />
					<label for="Date_2">Date 2</label>
					<input type="text" name="Date_2" id="Date_2" validators="date|dd/mm/yyyy|-|3|Date_1" />
					<label for="Date_3">Date 3</label>
					<input type="text" name="Date_3" id="Date_3" validators="date|yyyy/mm/dd| |4|Date_2" />
				</fieldset>
				<fieldset>
					<legend>Credit Cards</legend>
					<label for="Credit_Card_Type">Credit Card Type</label>
					<select name="Credit_Card_Type" id="Credit_Card_Type" validators="selecti|0,1,6,10" onblur="ChangeCCType(this)">
						<option value="" selected="selected">Pick Your Card</option>
						<option value="">---------------</option>
						<option value="VISA">Visa</option>
						<option value="MC">Master Card</option>
						<option value="DISC">Discover</option>
						<option value="AMEX">American Express</option>
						<option value="">---------------</option>
						<option value="DINERS">Diners Club</option>
						<option value="ENROUTE">enRoute Card</option>
						<option value="JCB">JCB Card</option>
						<option value="">---------------</option>
						<option value="Switch">Switch</option>
						<option value="Delta">Delta</option>
						<option value="Solo">Solo</option>
					</select>
					<label for="Credit_Card_Number">Credit Card Number</label>
					<input type="text" name="Credit_Card_Number" id="Credit_Card_Number" validators="cc|bok" />
				</fieldset>
			</div>
			<div>
				<fieldset>
					<legend>Textarea</legend>
					<label for="Comments">Comments</label>
					<textarea name="Comments" id="Comments" validators="length|10|100"></textarea>
				</fieldset>
			</div>
			<div class="formFooter">
				<input type="reset" name="Reset" value="Reset" onclick="this.form.Submit.disabled=false;" />
				<input type="submit" name="Submit" value="Try it" />
			</div>
		</form>
	</body>
</html>