using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium133";
        public override double halfLife { get; } = 0.165d;
        public override double atomicWeight { get; } = 132.93807d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin133()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin133()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    