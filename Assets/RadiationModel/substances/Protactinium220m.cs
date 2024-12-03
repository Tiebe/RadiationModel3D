using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Protactinium220m : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium220m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 220.0218d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium216()), new(1.0d, new AlphaParticle(10751002.09)) } },
            { 3e-09d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Actinium220()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    