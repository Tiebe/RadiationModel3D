using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum204 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum204";
        public override double halfLife { get; } = 10.3d;
        public override double atomicWeight { get; } = 203.98108d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gold204()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    