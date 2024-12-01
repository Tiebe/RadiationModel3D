using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Zinc55 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc55";
        public override double halfLife { get; } = 0.0198d;
        public override double atomicWeight { get; } = 54.98468d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel55()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.91d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel54()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    