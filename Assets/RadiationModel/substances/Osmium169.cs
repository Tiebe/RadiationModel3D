using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium169 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium169";
        public override double halfLife { get; } = 3.43d;
        public override double atomicWeight { get; } = 168.96702d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.863d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten169()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.13699999999999998d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten165()), new(1.0d, new AlphaParticle(6735002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    