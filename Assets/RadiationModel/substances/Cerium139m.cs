using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium139m";
        public override double halfLife { get; } = 57.58d;
        public override double atomicWeight { get; } = 138.90746d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium139() }, { 0.9259999999999999d, new GammaParticle(754240.0, 0.00164) }, { 0.00795755d, new GammaParticle(5410.0, 0.22918) }, { 0.015600423311932428d, new GammaParticle(34279.0, 0.03617) }, { 0.028572203868008107d, new GammaParticle(34720.0, 0.03571) }, { 0.008605560462567365d, new GammaParticle(39366.0, 0.0315) }, { 0.010791372820059476d, new GammaParticle(39753.0, 0.03119) }, { 0.0021858123574921102d, new GammaParticle(40229.0, 0.03082) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    