using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nitrogen23 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen23";
        public override double halfLife { get; } = 0.0141d;
        public override double atomicWeight { get; } = 23.03942d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Oxygen23()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.42d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Oxygen23()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.08d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Oxygen21()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new NeutronParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    