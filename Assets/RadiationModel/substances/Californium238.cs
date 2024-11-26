using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium238";
        public override double halfLife { get; } = 0.0211d;
        public override double atomicWeight { get; } = 238.06149d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium234() }, { 1.0d, new AlphaParticle(9155002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    