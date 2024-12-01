using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nobelium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium256";
        public override double halfLife { get; } = 2.91d;
        public override double atomicWeight { get; } = 256.09428d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9947d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Fermium252()), new(1.0d, new AlphaParticle(9603002.09)) } },
            { 0.0053d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    