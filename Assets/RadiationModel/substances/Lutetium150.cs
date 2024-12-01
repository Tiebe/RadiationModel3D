using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium150";
        public override double halfLife { get; } = 0.045d;
        public override double atomicWeight { get; } = 149.97341d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7090000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium149()), new(1.0d, new ProtonParticle()) } },
            { 0.29100000000000004d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium150()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    