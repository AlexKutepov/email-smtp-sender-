### English

# Email Sender Application

## Description
This application allows users to send bulk emails using a provided list of recipients. It supports sending emails through an SMTP server and provides options for configuring the email content and delivery parameters.

## Features
- **Bulk Email Sending**: Users can send emails to a large number of recipients at once.
- **SMTP Configuration**: Users can configure the SMTP server details such as host, port, username, and password.
- **Customizable Email Content**: Users can customize the email subject and message body.
- **Recipient List**: Users can load recipient email addresses from a CSV file or manually enter them using a text box.
- **Rich Text Support**: Supports loading recipient email addresses from a RichTextBox.
- **Pause and Resume**: Users can pause and resume the email sending process.
- **Stop Sending**: Users can stop the email sending process at any time.
- **Error Logging**: Logs errors encountered during email sending to a file for later analysis.

## Usage
1. Enter the SMTP server details including host, port, username, and password.
2. Enter the sender's name and email address.
3. Enter the email subject and message body.
4. Load recipient email addresses from a CSV file or enter them manually.
5. Optionally, use RichTextBox for entering recipient email addresses.
6. Configure the number of emails to send per iteration and the delay between iterations.
7. Click the "Send" button to start sending emails.
8. Use the "Pause" button to pause the sending process and "Resume" to continue.
9. Use the "Stop" button to halt the sending process.

## Technologies Used
- C#
- Windows Forms
- MailKit

### Русский

# Приложение для отправки электронной почты

## Описание
Это приложение позволяет пользователям отправлять массовые электронные письма, используя предоставленный список получателей. Оно поддерживает отправку электронных писем через SMTP-сервер и предоставляет возможности настройки содержимого электронной почты и параметров доставки.

## Особенности
- **Массовая отправка писем**: Пользователи могут отправлять письма большому количеству получателей одновременно.
- **Настройка SMTP**: Пользователи могут настроить параметры SMTP-сервера, такие как хост, порт, имя пользователя и пароль.
- **Настройка содержимого письма**: Пользователи могут настроить тему письма и текст сообщения.
- **Список получателей**: Пользователи могут загружать адреса электронной почты получателей из файла CSV или вводить их вручную с помощью текстового поля.
- **Поддержка форматированного текста**: Поддерживает загрузку адресов электронной почты получателей из RichTextBox.
- **Пауза и продолжение**: Пользователи могут приостановить и возобновить процесс отправки писем.
- **Остановка отправки**: Пользователи могут остановить процесс отправки писем в любое время.
- **Логирование ошибок**: Регистрирует ошибки, возникшие во время отправки писем, в файл для последующего анализа.

## Использование
1. Введите данные SMTP-сервера, включая хост, порт, имя пользователя и пароль.
2. Введите имя и адрес электронной почты отправителя.
3. Введите тему письма и текст сообщения.
4. Загрузите адреса электронной почты получателей из файла CSV или введите их вручную.
5. По желанию используйте RichTextBox для ввода адресов электронной почты получателей.
6. Настройте количество отправляемых писем за итерацию и задержку между итерациями.
7. Нажмите кнопку "Отправить", чтобы начать отправку писем.
8. Используйте кнопку "Пауза", чтобы приостановить процесс отправки, и "Продолжить", чтобы продолжить.
9. Используйте кнопку "Остановить", чтобы прекратить процесс отправки.

## Используемые технологии
- C#
- Windows Forms
- MailKit
