using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium151 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium151";
        public override double halfLife { get; } = 0.0806d;
        public override double atomicWeight { get; } = 150.96747d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.634d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ytterbium150() }, { 1.0d, new ProtonParticle() } } },
            { 0.366d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium151() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    