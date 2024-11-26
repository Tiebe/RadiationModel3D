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

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cerium139()), new(0.9259999999999999d, new GammaParticle(754240.0, 0.00164)), new(0.00795755d, new GammaParticle(5410.0, 0.22918)), new(0.015600423311932428d, new GammaParticle(34279.0, 0.03617)), new(0.028572203868008107d, new GammaParticle(34720.0, 0.03571)), new(0.008605560462567365d, new GammaParticle(39366.0, 0.0315)), new(0.010791372820059476d, new GammaParticle(39753.0, 0.03119)), new(0.0021858123574921102d, new GammaParticle(40229.0, 0.03082)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    