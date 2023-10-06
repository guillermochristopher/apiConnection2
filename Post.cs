using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiConnection
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Poat>(myJsonResponse);
    public class Data
    {
        [JsonProperty("currency")]
        public string Currency;

        [JsonProperty("rates")]
        public Rates Rates;
    }

    public class Rates
    {
        [JsonProperty("00")]
        public string _00;

        [JsonProperty("1INCH")]
        public string _1INCH;

        [JsonProperty("AAVE")]
        public string AAVE;

        [JsonProperty("ABT")]
        public string ABT;

        [JsonProperty("ACH")]
        public string ACH;

        [JsonProperty("ACS")]
        public string ACS;

        [JsonProperty("ADA")]
        public string ADA;

        [JsonProperty("AED")]
        public string AED;

        [JsonProperty("AERGO")]
        public string AERGO;

        [JsonProperty("AFN")]
        public string AFN;

        [JsonProperty("AGLD")]
        public string AGLD;

        [JsonProperty("AIOZ")]
        public string AIOZ;

        [JsonProperty("ALCX")]
        public string ALCX;

        [JsonProperty("ALEPH")]
        public string ALEPH;

        [JsonProperty("ALGO")]
        public string ALGO;

        [JsonProperty("ALICE")]
        public string ALICE;

        [JsonProperty("ALL")]
        public string ALL;

        [JsonProperty("AMD")]
        public string AMD;

        [JsonProperty("AMP")]
        public string AMP;

        [JsonProperty("ANG")]
        public string ANG;

        [JsonProperty("ANKR")]
        public string ANKR;

        [JsonProperty("ANT")]
        public string ANT;

        [JsonProperty("AOA")]
        public string AOA;

        [JsonProperty("APE")]
        public string APE;

        [JsonProperty("API3")]
        public string API3;

        [JsonProperty("APT")]
        public string APT;

        [JsonProperty("ARB")]
        public string ARB;

        [JsonProperty("ARPA")]
        public string ARPA;

        [JsonProperty("ARS")]
        public string ARS;

        [JsonProperty("ASM")]
        public string ASM;

        [JsonProperty("AST")]
        public string AST;

        [JsonProperty("ATA")]
        public string ATA;

        [JsonProperty("ATOM")]
        public string ATOM;

        [JsonProperty("AUCTION")]
        public string AUCTION;

        [JsonProperty("AUD")]
        public string AUD;

        [JsonProperty("AUDIO")]
        public string AUDIO;

        [JsonProperty("AURORA")]
        public string AURORA;

        [JsonProperty("AVAX")]
        public string AVAX;

        [JsonProperty("AVT")]
        public string AVT;

        [JsonProperty("AWG")]
        public string AWG;

        [JsonProperty("AXL")]
        public string AXL;

        [JsonProperty("AXS")]
        public string AXS;

        [JsonProperty("AZN")]
        public string AZN;

        [JsonProperty("BADGER")]
        public string BADGER;

        [JsonProperty("BAL")]
        public string BAL;

        [JsonProperty("BAM")]
        public string BAM;

        [JsonProperty("BAND")]
        public string BAND;

        [JsonProperty("BAT")]
        public string BAT;

        [JsonProperty("BBD")]
        public string BBD;

        [JsonProperty("BCH")]
        public string BCH;

        [JsonProperty("BDT")]
        public string BDT;

        [JsonProperty("BGN")]
        public string BGN;

        [JsonProperty("BHD")]
        public string BHD;

        [JsonProperty("BICO")]
        public string BICO;

        [JsonProperty("BIF")]
        public string BIF;

        [JsonProperty("BIT")]
        public string BIT;

        [JsonProperty("BLUR")]
        public string BLUR;

        [JsonProperty("BLZ")]
        public string BLZ;

        [JsonProperty("BMD")]
        public string BMD;

        [JsonProperty("BND")]
        public string BND;

        [JsonProperty("BNT")]
        public string BNT;

        [JsonProperty("BOB")]
        public string BOB;

        [JsonProperty("BOBA")]
        public string BOBA;

        [JsonProperty("BOND")]
        public string BOND;

        [JsonProperty("BRL")]
        public string BRL;

        [JsonProperty("BSD")]
        public string BSD;

        [JsonProperty("BSV")]
        public string BSV;

        [JsonProperty("BTC")]
        public string BTC;

        [JsonProperty("BTN")]
        public string BTN;

        [JsonProperty("BTRST")]
        public string BTRST;

        [JsonProperty("BUSD")]
        public string BUSD;

        [JsonProperty("BWP")]
        public string BWP;

        [JsonProperty("BYN")]
        public string BYN;

        [JsonProperty("BYR")]
        public string BYR;

        [JsonProperty("BZD")]
        public string BZD;

        [JsonProperty("C98")]
        public string C98;

        [JsonProperty("CAD")]
        public string CAD;

        [JsonProperty("CBETH")]
        public string CBETH;

        [JsonProperty("CDF")]
        public string CDF;

        [JsonProperty("CELR")]
        public string CELR;

        [JsonProperty("CGLD")]
        public string CGLD;

        [JsonProperty("CHF")]
        public string CHF;

        [JsonProperty("CHZ")]
        public string CHZ;

        [JsonProperty("CLF")]
        public string CLF;

        [JsonProperty("CLP")]
        public string CLP;

        [JsonProperty("CLV")]
        public string CLV;

        [JsonProperty("CNH")]
        public string CNH;

        [JsonProperty("CNY")]
        public string CNY;

        [JsonProperty("COMP")]
        public string COMP;

        [JsonProperty("COP")]
        public string COP;

        [JsonProperty("COTI")]
        public string COTI;

        [JsonProperty("COVAL")]
        public string COVAL;

        [JsonProperty("CRC")]
        public string CRC;

        [JsonProperty("CRO")]
        public string CRO;

        [JsonProperty("CRPT")]
        public string CRPT;

        [JsonProperty("CRV")]
        public string CRV;

        [JsonProperty("CTSI")]
        public string CTSI;

        [JsonProperty("CTX")]
        public string CTX;

        [JsonProperty("CUC")]
        public string CUC;

        [JsonProperty("CUP")]
        public string CUP;

        [JsonProperty("CVC")]
        public string CVC;

        [JsonProperty("CVE")]
        public string CVE;

        [JsonProperty("CVX")]
        public string CVX;

        [JsonProperty("CZK")]
        public string CZK;

        [JsonProperty("DAI")]
        public string DAI;

        [JsonProperty("DAR")]
        public string DAR;

        [JsonProperty("DASH")]
        public string DASH;

        [JsonProperty("DDX")]
        public string DDX;

        [JsonProperty("DESO")]
        public string DESO;

        [JsonProperty("DEXT")]
        public string DEXT;

        [JsonProperty("DIA")]
        public string DIA;

        [JsonProperty("DIMO")]
        public string DIMO;

        [JsonProperty("DJF")]
        public string DJF;

        [JsonProperty("DKK")]
        public string DKK;

        [JsonProperty("DNT")]
        public string DNT;

        [JsonProperty("DOGE")]
        public string DOGE;

        [JsonProperty("DOP")]
        public string DOP;

        [JsonProperty("DOT")]
        public string DOT;

        [JsonProperty("DREP")]
        public string DREP;

        [JsonProperty("DYP")]
        public string DYP;

        [JsonProperty("DZD")]
        public string DZD;

        [JsonProperty("EEK")]
        public string EEK;

        [JsonProperty("EGLD")]
        public string EGLD;

        [JsonProperty("EGP")]
        public string EGP;

        [JsonProperty("ELA")]
        public string ELA;

        [JsonProperty("ENJ")]
        public string ENJ;

        [JsonProperty("ENS")]
        public string ENS;

        [JsonProperty("EOS")]
        public string EOS;

        [JsonProperty("ERN")]
        public string ERN;

        [JsonProperty("ETB")]
        public string ETB;

        [JsonProperty("ETC")]
        public string ETC;

        [JsonProperty("ETH")]
        public string ETH;

        [JsonProperty("ETH2")]
        public string ETH2;

        [JsonProperty("EUR")]
        public string EUR;

        [JsonProperty("EUROC")]
        public string EUROC;

        [JsonProperty("FARM")]
        public string FARM;

        [JsonProperty("FET")]
        public string FET;

        [JsonProperty("FIDA")]
        public string FIDA;

        [JsonProperty("FIL")]
        public string FIL;

        [JsonProperty("FIS")]
        public string FIS;

        [JsonProperty("FJD")]
        public string FJD;

        [JsonProperty("FKP")]
        public string FKP;

        [JsonProperty("FLOW")]
        public string FLOW;

        [JsonProperty("FLR")]
        public string FLR;

        [JsonProperty("FORT")]
        public string FORT;

        [JsonProperty("FORTH")]
        public string FORTH;

        [JsonProperty("FOX")]
        public string FOX;

        [JsonProperty("FX")]
        public string FX;

        [JsonProperty("GAL")]
        public string GAL;

        [JsonProperty("GALA")]
        public string GALA;

        [JsonProperty("GBP")]
        public string GBP;

        [JsonProperty("GEL")]
        public string GEL;

        [JsonProperty("GFI")]
        public string GFI;

        [JsonProperty("GGP")]
        public string GGP;

        [JsonProperty("GHS")]
        public string GHS;

        [JsonProperty("GHST")]
        public string GHST;

        [JsonProperty("GIP")]
        public string GIP;

        [JsonProperty("GLM")]
        public string GLM;

        [JsonProperty("GMD")]
        public string GMD;

        [JsonProperty("GMT")]
        public string GMT;

        [JsonProperty("GNF")]
        public string GNF;

        [JsonProperty("GNO")]
        public string GNO;

        [JsonProperty("GNT")]
        public string GNT;

        [JsonProperty("GODS")]
        public string GODS;

        [JsonProperty("GRT")]
        public string GRT;

        [JsonProperty("GST")]
        public string GST;

        [JsonProperty("GTC")]
        public string GTC;

        [JsonProperty("GTQ")]
        public string GTQ;

        [JsonProperty("GUSD")]
        public string GUSD;

        [JsonProperty("GYD")]
        public string GYD;

        [JsonProperty("GYEN")]
        public string GYEN;

        [JsonProperty("HBAR")]
        public string HBAR;

        [JsonProperty("HFT")]
        public string HFT;

        [JsonProperty("HIGH")]
        public string HIGH;

        [JsonProperty("HKD")]
        public string HKD;

        [JsonProperty("HNL")]
        public string HNL;

        [JsonProperty("HNT")]
        public string HNT;

        [JsonProperty("HOPR")]
        public string HOPR;

        [JsonProperty("HRK")]
        public string HRK;

        [JsonProperty("HTG")]
        public string HTG;

        [JsonProperty("HUF")]
        public string HUF;

        [JsonProperty("ICP")]
        public string ICP;

        [JsonProperty("IDEX")]
        public string IDEX;

        [JsonProperty("IDR")]
        public string IDR;

        [JsonProperty("ILS")]
        public string ILS;

        [JsonProperty("ILV")]
        public string ILV;

        [JsonProperty("IMP")]
        public string IMP;

        [JsonProperty("IMX")]
        public string IMX;

        [JsonProperty("INDEX")]
        public string INDEX;

        [JsonProperty("INJ")]
        public string INJ;

        [JsonProperty("INR")]
        public string INR;

        [JsonProperty("INV")]
        public string INV;

        [JsonProperty("IOTX")]
        public string IOTX;

        [JsonProperty("IQD")]
        public string IQD;

        [JsonProperty("IRR")]
        public string IRR;

        [JsonProperty("ISK")]
        public string ISK;

        [JsonProperty("JASMY")]
        public string JASMY;

        [JsonProperty("JEP")]
        public string JEP;

        [JsonProperty("JMD")]
        public string JMD;

        [JsonProperty("JOD")]
        public string JOD;

        [JsonProperty("JPY")]
        public string JPY;

        [JsonProperty("JUP")]
        public string JUP;

        [JsonProperty("KAVA")]
        public string KAVA;

        [JsonProperty("KEEP")]
        public string KEEP;

        [JsonProperty("KES")]
        public string KES;

        [JsonProperty("KGS")]
        public string KGS;

        [JsonProperty("KHR")]
        public string KHR;

        [JsonProperty("KMF")]
        public string KMF;

        [JsonProperty("KNC")]
        public string KNC;

        [JsonProperty("KPW")]
        public string KPW;

        [JsonProperty("KRL")]
        public string KRL;

        [JsonProperty("KRW")]
        public string KRW;

        [JsonProperty("KSM")]
        public string KSM;

        [JsonProperty("KWD")]
        public string KWD;

        [JsonProperty("KYD")]
        public string KYD;

        [JsonProperty("KZT")]
        public string KZT;

        [JsonProperty("LAK")]
        public string LAK;

        [JsonProperty("LBP")]
        public string LBP;

        [JsonProperty("LCX")]
        public string LCX;

        [JsonProperty("LDO")]
        public string LDO;

        [JsonProperty("LINK")]
        public string LINK;

        [JsonProperty("LIT")]
        public string LIT;

        [JsonProperty("LKR")]
        public string LKR;

        [JsonProperty("LOKA")]
        public string LOKA;

        [JsonProperty("LOOM")]
        public string LOOM;

        [JsonProperty("LPT")]
        public string LPT;

        [JsonProperty("LQTY")]
        public string LQTY;

        [JsonProperty("LRC")]
        public string LRC;

        [JsonProperty("LRD")]
        public string LRD;

        [JsonProperty("LSETH")]
        public string LSETH;

        [JsonProperty("LSL")]
        public string LSL;

        [JsonProperty("LTC")]
        public string LTC;

        [JsonProperty("LTL")]
        public string LTL;

        [JsonProperty("LVL")]
        public string LVL;

        [JsonProperty("LYD")]
        public string LYD;

        [JsonProperty("MAD")]
        public string MAD;

        [JsonProperty("MAGIC")]
        public string MAGIC;

        [JsonProperty("MANA")]
        public string MANA;

        [JsonProperty("MASK")]
        public string MASK;

        [JsonProperty("MATH")]
        public string MATH;

        [JsonProperty("MATIC")]
        public string MATIC;

        [JsonProperty("MCO2")]
        public string MCO2;

        [JsonProperty("MDL")]
        public string MDL;

        [JsonProperty("MDT")]
        public string MDT;

        [JsonProperty("MEDIA")]
        public string MEDIA;

        [JsonProperty("METIS")]
        public string METIS;

        [JsonProperty("MGA")]
        public string MGA;

        [JsonProperty("MINA")]
        public string MINA;

        [JsonProperty("MIR")]
        public string MIR;

        [JsonProperty("MKD")]
        public string MKD;

        [JsonProperty("MKR")]
        public string MKR;

        [JsonProperty("MLN")]
        public string MLN;

        [JsonProperty("MMK")]
        public string MMK;

        [JsonProperty("MNDE")]
        public string MNDE;

        [JsonProperty("MNT")]
        public string MNT;

        [JsonProperty("MONA")]
        public string MONA;

        [JsonProperty("MOP")]
        public string MOP;

        [JsonProperty("MPL")]
        public string MPL;

        [JsonProperty("MRO")]
        public string MRO;

        [JsonProperty("MRU")]
        public string MRU;

        [JsonProperty("MSOL")]
        public string MSOL;

        [JsonProperty("MTL")]
        public string MTL;

        [JsonProperty("MULTI")]
        public string MULTI;

        [JsonProperty("MUR")]
        public string MUR;

        [JsonProperty("MUSD")]
        public string MUSD;

        [JsonProperty("MUSE")]
        public string MUSE;

        [JsonProperty("MVR")]
        public string MVR;

        [JsonProperty("MWK")]
        public string MWK;

        [JsonProperty("MXC")]
        public string MXC;

        [JsonProperty("MXN")]
        public string MXN;

        [JsonProperty("MYR")]
        public string MYR;

        [JsonProperty("MZN")]
        public string MZN;

        [JsonProperty("NAD")]
        public string NAD;

        [JsonProperty("NCT")]
        public string NCT;

        [JsonProperty("NEAR")]
        public string NEAR;

        [JsonProperty("NEST")]
        public string NEST;

        [JsonProperty("NGN")]
        public string NGN;

        [JsonProperty("NIO")]
        public string NIO;

        [JsonProperty("NKN")]
        public string NKN;

        [JsonProperty("NMR")]
        public string NMR;

        [JsonProperty("NOK")]
        public string NOK;

        [JsonProperty("NPR")]
        public string NPR;

        [JsonProperty("NU")]
        public string NU;

        [JsonProperty("NZD")]
        public string NZD;

        [JsonProperty("OCEAN")]
        public string OCEAN;

        [JsonProperty("OGN")]
        public string OGN;

        [JsonProperty("OMG")]
        public string OMG;

        [JsonProperty("OMR")]
        public string OMR;

        [JsonProperty("OOKI")]
        public string OOKI;

        [JsonProperty("OP")]
        public string OP;

        [JsonProperty("ORCA")]
        public string ORCA;

        [JsonProperty("ORN")]
        public string ORN;

        [JsonProperty("OSMO")]
        public string OSMO;

        [JsonProperty("OXT")]
        public string OXT;

        [JsonProperty("PAB")]
        public string PAB;

        [JsonProperty("PAX")]
        public string PAX;

        [JsonProperty("PEN")]
        public string PEN;

        [JsonProperty("PERP")]
        public string PERP;

        [JsonProperty("PGK")]
        public string PGK;

        [JsonProperty("PHP")]
        public string PHP;

        [JsonProperty("PKR")]
        public string PKR;

        [JsonProperty("PLA")]
        public string PLA;

        [JsonProperty("PLN")]
        public string PLN;

        [JsonProperty("PLU")]
        public string PLU;

        [JsonProperty("PNG")]
        public string PNG;

        [JsonProperty("POLS")]
        public string POLS;

        [JsonProperty("POLY")]
        public string POLY;

        [JsonProperty("POND")]
        public string POND;

        [JsonProperty("POWR")]
        public string POWR;

        [JsonProperty("PRIME")]
        public string PRIME;

        [JsonProperty("PRO")]
        public string PRO;

        [JsonProperty("PRQ")]
        public string PRQ;

        [JsonProperty("PUNDIX")]
        public string PUNDIX;

        [JsonProperty("PYG")]
        public string PYG;

        [JsonProperty("PYR")]
        public string PYR;

        [JsonProperty("PYUSD")]
        public string PYUSD;

        [JsonProperty("QAR")]
        public string QAR;

        [JsonProperty("QI")]
        public string QI;

        [JsonProperty("QNT")]
        public string QNT;

        [JsonProperty("QSP")]
        public string QSP;

        [JsonProperty("QUICK")]
        public string QUICK;

        [JsonProperty("RAD")]
        public string RAD;

        [JsonProperty("RAI")]
        public string RAI;

        [JsonProperty("RARE")]
        public string RARE;

        [JsonProperty("RARI")]
        public string RARI;

        [JsonProperty("RBN")]
        public string RBN;

        [JsonProperty("REN")]
        public string REN;

        [JsonProperty("REP")]
        public string REP;

        [JsonProperty("REPV2")]
        public string REPV2;

        [JsonProperty("REQ")]
        public string REQ;

        [JsonProperty("RGT")]
        public string RGT;

        [JsonProperty("RLC")]
        public string RLC;

        [JsonProperty("RLY")]
        public string RLY;

        [JsonProperty("RNDR")]
        public string RNDR;

        [JsonProperty("RON")]
        public string RON;

        [JsonProperty("ROSE")]
        public string ROSE;

        [JsonProperty("RPL")]
        public string RPL;

        [JsonProperty("RSD")]
        public string RSD;

        [JsonProperty("RUB")]
        public string RUB;

        [JsonProperty("RWF")]
        public string RWF;

        [JsonProperty("SAND")]
        public string SAND;

        [JsonProperty("SAR")]
        public string SAR;

        [JsonProperty("SBD")]
        public string SBD;

        [JsonProperty("SCR")]
        public string SCR;

        [JsonProperty("SDG")]
        public string SDG;

        [JsonProperty("SEI")]
        public string SEI;

        [JsonProperty("SEK")]
        public string SEK;

        [JsonProperty("SGD")]
        public string SGD;

        [JsonProperty("SHIB")]
        public string SHIB;

        [JsonProperty("SHP")]
        public string SHP;

        [JsonProperty("SHPING")]
        public string SHPING;

        [JsonProperty("SKK")]
        public string SKK;

        [JsonProperty("SKL")]
        public string SKL;

        [JsonProperty("SLL")]
        public string SLL;

        [JsonProperty("SNT")]
        public string SNT;

        [JsonProperty("SNX")]
        public string SNX;

        [JsonProperty("SOL")]
        public string SOL;

        [JsonProperty("SOS")]
        public string SOS;

        [JsonProperty("SPA")]
        public string SPA;

        [JsonProperty("SPELL")]
        public string SPELL;

        [JsonProperty("SRD")]
        public string SRD;

        [JsonProperty("SSP")]
        public string SSP;

        [JsonProperty("STD")]
        public string STD;

        [JsonProperty("STG")]
        public string STG;

        [JsonProperty("STORJ")]
        public string STORJ;

        [JsonProperty("STX")]
        public string STX;

        [JsonProperty("SUI")]
        public string SUI;

        [JsonProperty("SUKU")]
        public string SUKU;

        [JsonProperty("SUPER")]
        public string SUPER;

        [JsonProperty("SUSHI")]
        public string SUSHI;

        [JsonProperty("SVC")]
        public string SVC;

        [JsonProperty("SWFTC")]
        public string SWFTC;

        [JsonProperty("SYLO")]
        public string SYLO;

        [JsonProperty("SYN")]
        public string SYN;

        [JsonProperty("SYP")]
        public string SYP;

        [JsonProperty("SZL")]
        public string SZL;

        [JsonProperty("T")]
        public string T;

        [JsonProperty("THB")]
        public string THB;

        [JsonProperty("TIME")]
        public string TIME;

        [JsonProperty("TJS")]
        public string TJS;

        [JsonProperty("TMM")]
        public string TMM;

        [JsonProperty("TMT")]
        public string TMT;

        [JsonProperty("TND")]
        public string TND;

        [JsonProperty("TONE")]
        public string TONE;

        [JsonProperty("TOP")]
        public string TOP;

        [JsonProperty("TRAC")]
        public string TRAC;

        [JsonProperty("TRB")]
        public string TRB;

        [JsonProperty("TRIBE")]
        public string TRIBE;

        [JsonProperty("TRU")]
        public string TRU;

        [JsonProperty("TRY")]
        public string TRY;

        [JsonProperty("TTD")]
        public string TTD;

        [JsonProperty("TVK")]
        public string TVK;

        [JsonProperty("TWD")]
        public string TWD;

        [JsonProperty("TZS")]
        public string TZS;

        [JsonProperty("UAH")]
        public string UAH;

        [JsonProperty("UGX")]
        public string UGX;

        [JsonProperty("UMA")]
        public string UMA;

        [JsonProperty("UNFI")]
        public string UNFI;

        [JsonProperty("UNI")]
        public string UNI;

        [JsonProperty("UPI")]
        public string UPI;

        [JsonProperty("USD")]
        public string USD;

        [JsonProperty("USDC")]
        public string USDC;

        [JsonProperty("USDT")]
        public string USDT;

        [JsonProperty("UST")]
        public string UST;

        [JsonProperty("UYU")]
        public string UYU;

        [JsonProperty("UZS")]
        public string UZS;

        [JsonProperty("VARA")]
        public string VARA;

        [JsonProperty("VEF")]
        public string VEF;

        [JsonProperty("VES")]
        public string VES;

        [JsonProperty("VET")]
        public string VET;

        [JsonProperty("VGX")]
        public string VGX;

        [JsonProperty("VND")]
        public string VND;

        [JsonProperty("VOXEL")]
        public string VOXEL;

        [JsonProperty("VTHO")]
        public string VTHO;

        [JsonProperty("VUV")]
        public string VUV;

        [JsonProperty("WAMPL")]
        public string WAMPL;

        [JsonProperty("WAXL")]
        public string WAXL;

        [JsonProperty("WBTC")]
        public string WBTC;

        [JsonProperty("WCFG")]
        public string WCFG;

        [JsonProperty("WLUNA")]
        public string WLUNA;

        [JsonProperty("WST")]
        public string WST;

        [JsonProperty("XAF")]
        public string XAF;

        [JsonProperty("XAG")]
        public string XAG;

        [JsonProperty("XAU")]
        public string XAU;

        [JsonProperty("XCD")]
        public string XCD;

        [JsonProperty("XCN")]
        public string XCN;

        [JsonProperty("XDR")]
        public string XDR;

        [JsonProperty("XLM")]
        public string XLM;

        [JsonProperty("XMON")]
        public string XMON;

        [JsonProperty("XOF")]
        public string XOF;

        [JsonProperty("XPD")]
        public string XPD;

        [JsonProperty("XPF")]
        public string XPF;

        [JsonProperty("XPT")]
        public string XPT;

        [JsonProperty("XRP")]
        public string XRP;

        [JsonProperty("XTZ")]
        public string XTZ;

        [JsonProperty("XYO")]
        public string XYO;

        [JsonProperty("YER")]
        public string YER;

        [JsonProperty("YFI")]
        public string YFI;

        [JsonProperty("YFII")]
        public string YFII;

        [JsonProperty("ZAR")]
        public string ZAR;

        [JsonProperty("ZEC")]
        public string ZEC;

        [JsonProperty("ZEN")]
        public string ZEN;

        [JsonProperty("ZMK")]
        public string ZMK;

        [JsonProperty("ZMW")]
        public string ZMW;

        [JsonProperty("ZRX")]
        public string ZRX;

        [JsonProperty("ZWD")]
        public string ZWD;
    }

    public class Root
    {
        [JsonProperty("data")]
        public Data Data;
    }


}
