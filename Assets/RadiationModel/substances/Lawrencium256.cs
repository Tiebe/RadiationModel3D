using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium256";
        public override double halfLife { get; } = 27.9d;
        public override double atomicWeight { get; } = 256.0985d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.85d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mendelevium252()), new(1.0d, new AlphaParticle(9877002.09)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium256()) } },
            { 0.0003d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    