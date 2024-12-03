using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium106m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium106m";
        public override double halfLife { get; } = 312.0d;
        public override double atomicWeight { get; } = 105.91349d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver106()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0012852d, new GammaParticle(427200.0, 0.0029)), new(0.0036720000000000004d, new GammaParticle(575200.0, 0.00216)), new(0.01377d, new GammaParticle(610700.0, 0.00203)), new(0.9179999999999999d, new GammaParticle(632660.0, 0.00196)), new(0.09179999999999999d, new GammaParticle(861100.0, 0.00144)), new(0.00459d, new GammaParticle(980700.0, 0.00126)), new(0.031212d, new GammaParticle(1083800.0, 0.00114)), new(0.015606d, new GammaParticle(1162600.0, 0.00107)), new(0.01377d, new GammaParticle(1471900.0, 0.00084)), new(0.0031212d, new GammaParticle(1511400.0, 0.00082)), new(0.14779799999999998d, new GammaParticle(1714900.0, 0.00072)), new(0.038556d, new GammaParticle(1716470.0, 0.00072)), new(0.014688000000000001d, new GammaParticle(1737900.0, 0.00071)), new(0.01377d, new GammaParticle(1745700.0, 0.00071)), new(0.069768d, new GammaParticle(1933600.0, 0.00064)), new(0.021114d, new GammaParticle(1997500.0, 0.00062)), new(0.022032d, new GammaParticle(2087300.0, 0.00059)), new(0.049572000000000005d, new GammaParticle(2256870.0, 0.00055)), new(0.008262d, new GammaParticle(2284800.0, 0.00054)), new(0.00459d, new GammaParticle(2304600.0, 0.00054)), new(0.010098000000000001d, new GammaParticle(2486600.0, 0.0005)), new(0.00918d, new GammaParticle(2696800.0, 0.00046)), new(0.008262d, new GammaParticle(2794700.0, 0.00044)), new(0.014688000000000001d, new GammaParticle(2862100.0, 0.00043)), new(0.038556d, new GammaParticle(2918200.0, 0.00042)), new(0.006425999999999999d, new GammaParticle(3118800.0, 0.0004)), new(0.007344000000000001d, new GammaParticle(3223000.0, 0.00038)), new(0.010098000000000001d, new GammaParticle(3394500.0, 0.00037)), new(0.021114d, new GammaParticle(3494500.0, 0.00035)), new(0.008262d, new GammaParticle(3889200.0, 0.00032)), new(0.00459d, new GammaParticle(3912000.0, 0.00032)), new(1.8208000000000002d, new GammaParticle(511000.0, 0.00243)), new(0.006999999999999999d, new GammaParticle(3388.0, 0.36595)), new(0.0246d, new GammaParticle(22983.0, 0.05395)), new(0.0463d, new GammaParticle(23173.0, 0.0535)), new(0.0129d, new GammaParticle(26184.0, 0.04735)), new(0.0152d, new GammaParticle(26381.0, 0.047)), new(0.0023499999999999997d, new GammaParticle(26641.0, 0.04654)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    