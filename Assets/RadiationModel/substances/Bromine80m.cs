using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bromine80m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine80m";
        public override double halfLife { get; } = 15913.8d;
        public override double atomicWeight { get; } = 79.91862d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine80()), new(0.391d, new GammaParticle(37052.0, 0.03346)), new(0.00317d, new GammaParticle(48850.0, 0.02538)), new(0.0338037923268d, new GammaParticle(1535.0, 0.80771)), new(0.22854296185575457d, new GammaParticle(11879.0, 0.10437)), new(0.44111747125218015d, new GammaParticle(11925.0, 0.10397)), new(0.10462667182701951d, new GammaParticle(13345.0, 0.09291)), new(0.11270385089206542d, new GammaParticle(13377.0, 0.09268)), new(0.008077179065045906d, new GammaParticle(13469.0, 0.09205)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    