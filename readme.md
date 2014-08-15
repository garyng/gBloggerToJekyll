gBloggerToJekyll
================

C# console application that convert Blogger posts to Jekyll posts

Prerequisite
=============
.net 4

Functions
============
Download and convert Google Blogger posts to Jekyll compatible posts (Liquid)

Blogger Post downloading function is based on Google's Blogger API v3

Post converting function is based on Pandoc and html2text

Before Using...
=========================
gBloggerToJeykll default uses Pandoc to convert Blogger posts to markdown, some of the formatting in posts may not be correctly converted (code highlighting and table), you have to convert it manually

Links in post that link to another post in the same blog can be converted to `{% post_url %}` by using the Link Conversion Helper that came along with gBloggerToJekyll

