using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium88m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium88m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 87.91279d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium88()), new(0.132d, new GammaParticle(27513.0, 0.04506)), new(0.55d, new GammaParticle(240710.0, 0.00515)), new(0.41d, new GammaParticle(313000.0, 0.00396)), new(0.04d, new GammaParticle(339800.0, 0.00365)), new(0.46d, new GammaParticle(386000.0, 0.00321)), new(0.46d, new GammaParticle(458300.0, 0.00271)), new(0.91d, new GammaParticle(647200.0, 0.00192)), new(0.09d, new GammaParticle(1105900.0, 0.00112)), new(0.021442748578800002d, new GammaParticle(1767.0, 0.70166)), new(0.13947005318079086d, new GammaParticle(13336.0, 0.09297)), new(0.26846978475609407d, new GammaParticle(13396.0, 0.09255)), new(0.06535810306730735d, new GammaParticle(15021.0, 0.08254)), new(0.07293964302311502d, new GammaParticle(15070.0, 0.08227)), new(0.0075815399558076535d, new GammaParticle(15187.0, 0.08164)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    