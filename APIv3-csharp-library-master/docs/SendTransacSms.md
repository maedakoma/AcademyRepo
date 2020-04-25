# sib_api_v3_sdk.Model.SendTransacSms
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | Name of the sender. Only alphanumeric characters. No more than 11 characters | 
**Recipient** | **string** | Mobile number to send SMS with the country code | 
**Content** | **string** | Content of the message. If more than 160 characters long, will be sent as multiple text messages | 
**Type** | **string** | Type of the SMS. Marketing SMS messages are those sent typically with marketing content. Transactional SMS messages are sent to individuals and are triggered in response to some action, such as a sign-up, purchase, etc. | [optional] [default to TypeEnum.Transactional]
**Tag** | **string** | Tag of the message | [optional] 
**WebUrl** | **string** | Webhook to call for each event triggered by the message (delivered etc.) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

