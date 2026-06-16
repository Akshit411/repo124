# repo124

## Project
Jira Ticket: **GG-371 – [MVP] Set up default configuration options at Chatbot level**

### Summary
Set up default ready-to-use conversation prompt engineering instructions for new chatbot definitions.

### User Story
As a SmartHub admin user, I should have access to default ready-to-use conversation prompt engineering instructions when defining a new chatbot so that I can efficiently set up the chatbot with predefined conversation prompts and guidelines, saving time and effort in the chatbot configuration process.

### Ticket Details
- **Type:** Bug
- **Project:** GG-Project
- **Status:** Done
- **Priority:** Medium
- **Assignee:** ggusti
- **Reporter:** Devops BAInsight
- **Creator:** Devops BAInsight
- **Team:** Development

## Solution Structure
This repository contains a simple C# domain model and service/repository interfaces to support default chatbot configuration behavior.

## Classes
- `Chatbot`
- `ChatbotConfiguration`
- `DefaultConfigurationTemplate`
- `PromptInstructionSet`
- `ResponseGuidelineSet`
- `ChatbotConfigurationService`
- `IDefaultConfigurationRepository`
- `IChatbotRepository`
