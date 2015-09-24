# What is the Open Device Identification Number? #

The Open Device Identification Number (ODIN) is a number designed for mobile app developers and service providers to uniquely identify their users’ devices in a convenient and interoperable manner. Unlike existing device identification schemes, ODIN is:

  * **Anonymous** A device’s ODIN does not encode any additional information beyond differentiating it from other ODINs. Having a single ODIN does not reveal any information about the originating device’s user, make, model, etc.

  * **Consistent** ODIN provides a standardized format for identifying devices regardless of software platform. Thus iOS, Android, Windows Phone, and future devices all use the same number format.

  * **Secure** The ODIN specification considers device identifiers to be personal information and details precautions in its transport accordingly. Additionally, even if the identifier were to be captured no additional information would be revealed beyond a unique number.

Maintenance of ODIN is administered by an ODIN Working Group (http://www.odinmobile.org) comprised of industry developers and service providers.

# Background #

In early 2008 Apple released the first public version of its iOS SDK ushering software developers worldwide into the modern era of mobile computing. This ecosystem was soon expanded with the introduction of a number of new mobile platforms including Google’s Android and Microsoft’s Windows Phone.

One of the features that all of these operating systems provided was an anonymous unique identifier that developers could use to identify devices using their applications. This has allowed for a number of innovations in personalization and analytics that have ultimately benefited consumers and businesses alike.

Recently, a number of issues have arisen around the usage of anonymous device identifiers prompting the need for a common framework that can address both the privacy concerns of end users and the interoperability concerns of service providers. It is the hope that ODIN can provide such a framework that can satisfy these needs as well as provide a foundation for accommodating any future industry change.