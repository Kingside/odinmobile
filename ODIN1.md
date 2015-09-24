## Nomenclature ##
The identifier generated in this implementation of ODIN is officially designated ODIN-1. In the event of a major revision, the new identifier will be termed ODIN-2 and so forth.

## Generating an ODIN-1 ##
Creating an ODIN-1 is designed to be as simple as possible:

1. **Identifier Seed Step**: Lookup the following Identifier Seed for each of the following platforms. The seed should be left unaltered from the format returned by the operating system.
| | iOS | Android | Windows Phone |
|:|:----|:--------|:--------------|
| Identifier Seed | 802.11 MAC Address | ANDROID\_ID | DeviceUniqueId |
| Format | Byte Array | Java String | C# String     |

```
// NOTE: iOS returns MAC Address NOT a string, but a 6-byte array. 

// A human readable MAC Address may be represented as the following:

@"1a:2b:3c:4d:5e:6f";
@"1A2B3C4D5E6F";

// However, representing it as a raw byte array prevents any ambiguity around punctuation and capitalization:

@[0x1a, 0x2b, 0x3c, 0x4d, 0x5e, 0x6f];

```

2. **Hash Step**: Pass the Identifier Seed through the SHA-1 hash function.

3.The resulting message digest is **ODIN-1**.

```

// The format of this hash should be a 40 lowercase character string:

@"82a53f1222f8781a5063a773231d4a7ee41bdd6f"

```

## Security ##

Because ODIN-1 is personally identifying information, any ODIN-1 must not be transmitted over unsecure connections as plain text.