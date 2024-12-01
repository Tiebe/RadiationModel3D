using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thulium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium147";
        public override double halfLife { get; } = 0.58d;
        public override double atomicWeight { get; } = 146.96138d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium147()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Erbium146()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    