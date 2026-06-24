# Project: Contact Book

A simple web app for storing and managing personal or business contacts.

---

## What the app does

A user can open the app and manage a list of contacts. They can add new contacts, view all existing ones, edit any contact's details, and delete contacts they no longer need.

---

## The single entity: `Contact`

| Field | Type | Notes |
|---|---|---|
| `Id` | int | Primary key, auto-generated |
| `FirstName` | string | Required |
| `LastName` | string | Required |
| `Email` | string | Required |
| `PhoneNumber` | string | Optional |
| `Company` | string | Optional |

---

## Pages required

### 1. `/contacts` — Contact List
- Shows all contacts in a table with columns: First Name, Last Name, Email, Phone Number, Company.
- Each row has an Edit link and a Delete button.
- If no contacts exist, shows "No contacts yet."
- Deleting a contact removes it immediately from the table and shows a brief "Deleted!" confirmation.

### 2. `/contacts/create` — Add Contact
- A form with fields for all five properties (Id is auto-generated, not on the form).
- A Save button that persists the contact to the database.
- On successful save, shows a "Saved!" message and clears the form so another contact can be added immediately.

### 3. `/contacts/edit/{Id:int}` — Edit Contact
- Loads the existing contact by Id from the URL.
- Pre-populates the form with current values.
- Saving updates the record in the database and shows a "Saved!" confirmation.
- If the Id doesn't exist, shows "Contact not found." with a link back to the list.
- Has a "Back to list" link regardless of whether the contact was found.

---

## Navigation
- A nav link to `/contacts` (the list page) in the sidebar.
- No nav link to `/contacts/create` — instead, put an "Add Contact" link/button on the list page itself, above the table. This is the more natural UX pattern for real apps.

---

## Technical requirements
- Blazor Web App, Interactive Server, .NET 10.
- PostgreSQL database via EF Core and Npgsql.
- Database must have a `Contacts` table with the correct columns — verified by querying it directly.
- Follow the folder structure you've been using: `Models/` for the entity, `Data/` for the DbContext, `Components/Pages/Contacts/` for the pages.

---

## Done means
- You can open the app fresh, add three contacts, see them all on the list, edit one and confirm the change persists in the database, delete one and confirm it's gone from both the UI and the database.
- No crashes on any of the four operations.
- No crashes when navigating to `/contacts/edit/9999` (a non-existent Id).
- The empty state on the list page works — if you delete all contacts, you see "No contacts yet." not a blank page or a broken table.

---

> That's it. No auth, no relationships, no file uploads, no search — just clean CRUD on one entity. If you can ship this without looking at the Todo app code, CRUD has stuck.
