using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium256";
        public override double halfLife { get; } = 0.00667d;
        public override double atomicWeight { get; } = 256.10115d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9968d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.0032d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium252()), new(1.0d, new AlphaParticle(9948002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    