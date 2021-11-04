Imports Google.Cloud.Translation.V2

Module Module1

    Sub Main()
        Dim translateClient As TranslationClient
        translateClient = TranslationClient.CreateFromApiKey(Utilty.GoogleCloudApiKey)
        Dim response As TranslationResult
        response = translateClient.TranslateText("আমি বাংলাদেশী", LanguageCodes.English, LanguageCodes.Bengali)
        Console.WriteLine(response.TranslatedText)
    End Sub

End Module
