using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton85m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton85m";
        public override double halfLife { get; } = 16128.0d;
        public override double atomicWeight { get; } = 84.91285d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7879999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium85()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00301d, new GammaParticle(129810.0, 0.00955)), new(0.752d, new GammaParticle(151195.0, 0.0082)), new(7.519999999999999e-06d, new GammaParticle(281010.0, 0.00441)), new(0.00010999999999999999d, new GammaParticle(451000.0, 0.00275)), new(7.519999999999999e-06d, new GammaParticle(580600.0, 0.00214)), new(8e-05d, new GammaParticle(731600.0, 0.00169)), new(0.00089d, new GammaParticle(1767.0, 0.70166)), new(0.00592d, new GammaParticle(13336.0, 0.09297)), new(0.011399999999999999d, new GammaParticle(13396.0, 0.09255)), new(0.0027700000000000003d, new GammaParticle(15021.0, 0.08254)), new(0.00309d, new GammaParticle(15070.0, 0.08227)), new(0.000322d, new GammaParticle(15187.0, 0.08164)) } },
            { 0.212d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton85()), new(0.14d, new GammaParticle(304870.0, 0.00407)), new(0.00168670768d, new GammaParticle(1648.0, 0.75233)), new(0.011473380338551893d, new GammaParticle(12596.0, 0.09843)), new(0.022123756919691272d, new GammaParticle(12649.0, 0.09802)), new(0.005301437810462244d, new GammaParticle(14169.0, 0.0875)), new(0.0058358227417568374d, new GammaParticle(14209.0, 0.08726)), new(0.0005343849312945942d, new GammaParticle(14313.0, 0.08662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    