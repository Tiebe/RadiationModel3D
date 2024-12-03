using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc78m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc78m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 77.94116d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Zinc78()), new(0.9d, new GammaParticle(144700.0, 0.00857)), new(1.0d, new GammaParticle(729600.0, 0.0017)), new(0.96d, new GammaParticle(889900.0, 0.00139)), new(1.02d, new GammaParticle(908300.0, 0.00137)), new(0.00201343968d, new GammaParticle(1035.0, 1.19791)), new(0.018734327164291093d, new GammaParticle(8616.0, 0.1439)), new(0.03643393069679326d, new GammaParticle(8639.0, 0.14352)), new(0.007817342138915653d, new GammaParticle(9610.0, 0.12902)), new(0.007817342138915653d, new GammaParticle(9610.0, 0.12902)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    