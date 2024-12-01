using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium255";
        public override double halfLife { get; } = 31.1d;
        public override double atomicWeight { get; } = 255.09656d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.997d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mendelevium251()), new(1.0d, new AlphaParticle(9577002.09)) } },
            { 0.003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium255()) } },
            { 0.001d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    