A simple winforms application
This application leverages API calls to Alpha Vantage's free API calls. An 
apiKey is required to be set in the environment settings for use within the
application. An apiKey can be requested here:
https://www.alphavantage.co/documentation/


On the form's main page, enter the API Key in the field provided.

This application performs data validation on the fields of the form before a 
call to the API is made.The request data is packaged in a request object and
submitted to the API service, which makes use of the API client. The response
is deserialized into a nested data model before processing for display on the
form.

When the stock symbol is submitted, a request will be made to an endpoint to
retrieve balance sheet data and simple moving average data. Click on each tab
to see the result.




