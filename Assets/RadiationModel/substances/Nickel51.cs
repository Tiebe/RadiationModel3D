using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel51 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel51";
        public override double halfLife { get; } = 0.0238d;
        public override double atomicWeight { get; } = 50.98749d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron51()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.872d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iron50()), new(1.0d, new ProtonParticle()), new(0.73d, new GammaParticle(765300.0, 0.00162)), new(0.29d, new GammaParticle(1086600.0, 0.00114)), new(0.042d, new GammaParticle(1545700.0, 0.0008)), new(0.044000000000000004d, new GammaParticle(1743400.0, 0.00071)) } },
            { 0.005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Manganese49()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    