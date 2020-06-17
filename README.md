# PollAplication
A poll application made for a local competition.
A user can search the team he wants and vote. You can no longer add or remove teams, their profiles are built static in Xml. 
We can vote one time/day.
When the competition is over, a password will be published, so they can see the results in the app. 


# What I've Learned
 - some fundamental xamarin.forms concept (xaml, preferences, dissabeling buttons etc.)
 - working with an online database (google firebase) (realtime database, some basic operations such as get and add)
 - publishing Android apps
 - & much more
 
Overall, as it is my first real project, I got familiarized working with this type of work.

# Bugs Discovered
If we delete and reinstall the app, we can vote as many times per day as we want.This is happening because I used preferences to save the last time someone voted.So whenever we reinstall the app, preferences reset.
