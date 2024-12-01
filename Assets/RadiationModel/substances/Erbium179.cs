using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Erbium179 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium179";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 178.96127d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thulium179()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    