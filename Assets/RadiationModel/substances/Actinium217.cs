using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium217";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 217.00934d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium213()), new(1.0d, new AlphaParticle(10853002.09)) } },
            { 0.02d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium217()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    