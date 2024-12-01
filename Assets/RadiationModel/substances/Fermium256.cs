using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Fermium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium256";
        public override double halfLife { get; } = 9426.0d;
        public override double atomicWeight { get; } = 256.09177d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.919d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.081d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Californium252()), new(1.0d, new AlphaParticle(8047402.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    