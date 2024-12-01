using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dubnium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium256";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 256.10768d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium252()), new(1.0d, new AlphaParticle(10357002.09)) } },
            { 0.3d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rutherfordium256()) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    