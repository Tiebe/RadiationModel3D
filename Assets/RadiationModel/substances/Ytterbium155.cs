using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium155 : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium155";
        public override double halfLife { get; } = 1.793d;
        public override double atomicWeight { get; } = 154.94578d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium151() }, { 1.0d, new AlphaParticle(6360002.09) } } },
            { 0.11d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium155() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    