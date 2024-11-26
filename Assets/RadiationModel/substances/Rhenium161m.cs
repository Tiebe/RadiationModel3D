using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium161m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium161m";
        public override double halfLife { get; } = 0.0147d;
        public override double atomicWeight { get; } = 160.97776d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum157() }, { 1.0d, new AlphaParticle(7477002.09) } } },
            { 0.07d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten160() }, { 1.0d, new ProtonParticle() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    