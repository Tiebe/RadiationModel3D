using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium86m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium86m";
        public override double halfLife { get; } = 61.02d;
        public override double atomicWeight { get; } = 85.91176d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium86()), new(0.9821d, new GammaParticle(556070.0, 0.00223)), new(0.00046397081175000003d, new GammaParticle(1767.0, 0.70166)), new(0.0030333143161857057d, new GammaParticle(13336.0, 0.09297)), new(0.005838911099491253d, new GammaParticle(13396.0, 0.09255)), new(0.0014214640719740503d, new GammaParticle(15021.0, 0.08254)), new(0.0015863539043230405d, new GammaParticle(15070.0, 0.08227)), new(0.00016488983234898985d, new GammaParticle(15187.0, 0.08164)) } },
            { 0.003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Strontium86()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    