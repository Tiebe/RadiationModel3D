using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium250";
        public override double halfLife { get; } = 412764591.74766d;
        public override double atomicWeight { get; } = 250.0764d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9992300000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium246() }, { 1.0d, new AlphaParticle(7150402.09) }, { 0.00016299999999999998d, new GammaParticle(42852.0, 0.02893) }, { 0.06752438d, new GammaParticle(18579.0, 0.06673) } } },
            { 0.00077d, new Dictionary<double, RadioactiveSubstance> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    