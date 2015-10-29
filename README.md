# `Hypixel C#`

A C# class for fetching information from the Hypixel Public API
https://api.hypixel.net

## Requirements
- Hypixel API key.
- The [Newtonsoft.Json](http://www.newtonsoft.com/json) framework

## Usage

To interact with the API you need an API key, you can get a key by doing "/api" on the Hypixel Network.

```C#
public partial class Example : Form
    {
        public Example()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerInfo = HypixelAPI.getPlayerByUuid("af2d221ba92f47618ab4e9b73e66447b");
            dynamic api = JsonConvert.DeserializeObject(playerInfo);

            string displayName = api.player.displayname;

            richTextBox1.Text = "Display Name: " + displayName;
        }
    }
```
![Example](https://i.gyazo.com/4ec7b29a0c5644536fd34931795783e4.gif)
