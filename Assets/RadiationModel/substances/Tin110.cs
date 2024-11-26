using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin110 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin110";
        public override double halfLife { get; } = 14954.4d;
        public override double atomicWeight { get; } = 109.90784d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium110() }, { 0.9706d, new GammaParticle(280459.0, 0.00442) }, { 0.06480473518886401d, new GammaParticle(3571.0, 0.3472) }, { 0.21055680231101245d, new GammaParticle(24001.0, 0.05166) }, { 0.39504090489871d, new GammaParticle(24209.0, 0.05121) }, { 0.11083964758846854d, new GammaParticle(27367.0, 0.0453) }, { 0.13189918063027756d, new GammaParticle(27581.0, 0.04495) }, { 0.021059533041809023d, new GammaParticle(27858.0, 0.04451) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    