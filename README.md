# PSG: Patient Billing Strip Generator

PSG is a small utilty designed to help doctors track how many times they've visited patients. It's designed primarily for my father, who creates small "Billing Strips" which contain basic patient information, along with a small box next to it for each time he's viewed the patient, with date, W or ICU (Ward or ICU), and C or F (Consult or Follow-up), along with a potential small note.

PSG stores patient information **UNENCRYPTED** so if you actually plan on using this, consider keeping your computer safe, or NTFS encrypting the generated MyPatients.PFILE.

PSG Does not communicate with the internet, so do not worry about having this information leak, unless you send the PFILE over the internet yourself.

Even if they do not plan on using this "Billing strip" method, PSG can still help doctors keep track of how and when they visited patients. I hope this may be of use to some!
