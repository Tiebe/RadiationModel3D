using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium164";
        public override double halfLife { get; } = 111.0d;
        public override double atomicWeight { get; } = 163.94437d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium164()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    