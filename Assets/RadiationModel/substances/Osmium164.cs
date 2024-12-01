using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium164";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 163.97808d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.96d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten160()), new(1.0d, new AlphaParticle(7507002.09)) } },
            { 0.04d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten164()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    