# Frequently Asked Questions #



## What if first party vendors repeal access to device identifiers? ##

Given that Apple has already repealed developer access to one anonymous device identifier, why wouldn’t it or any other first party platform providers do the same for other available identifiers?

Unfortunately, there is no way to be guarantee that this will not happen without explicit commitment from first parties. The goal of the ODIN Working Group is not to expressly solve this uncertainty, but to make sure that developers and service providers can coordinate on a standard for anonymous device identification.

In the event that any mobile platform completely revokes access to all unique device identifiers, a preliminary plan for non-guaranteed device identification has been conceived under the moniker ODIN-2: a Base64 256-bit compound number derived from a generated app specific identifier and transient device identifier. Originally, this was the plan for ODIN-1, but was shelved due to its complexity.

## How does ODIN address the Droid 2 problem? ##

In short it does not.

Due to an early bug in the Android platform, every single Motorola Droid 2 has the same ANDROID\_ID of “9774d56d682e549c”. This bug has since been fixed but creates a problem for developers and service providers trying to identify devices.

The reasons ODIN uses ANDROID\_ID in its Identifier Seed step are as follows:

  * Google recommends using ANDROID\_ID for device identification.
  * Google has fixed since fixed the bug.
  * Droid 2 is no longer in production and its install base can only decrease.
  * Droid 2 does not have significant market share and is not even one of the top ten Android phones.

## What is the Do Not Track Registry? ##

At the time of this writing, efforts are underway to organize a Do Not Track Registry. Functionally this registry would be similar to the National Do Not Call Registry. Any devices registered with the Do Not Track Registry could not be used for invasive tracking of ODINs.

The planning is currently in the early stages, so there are still numerous questions that need to be answered around governance, implementation, and enforcement. However, it is clear in light of recent events that some form of regulatory solution will be necessary to resolve many of the open privacy questions that currently exist around mobile device identification.