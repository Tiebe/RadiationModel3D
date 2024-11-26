using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium227";
        public override double halfLife { get; } = 66.0d;
        public override double atomicWeight { get; } = 227.03118d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium223()), new(1.0d, new AlphaParticle(8257002.09)), new(0.027999999999999997d, new GammaParticle(158000.0, 0.00785)), new(0.027999999999999997d, new GammaParticle(209000.0, 0.00593)), new(0.2d, new GammaParticle(247000.0, 0.00502)), new(0.03d, new GammaParticle(259000.0, 0.00479)), new(0.036000000000000004d, new GammaParticle(310000.0, 0.004)), new(0.18459432510399998d, new GammaParticle(15784.0, 0.07855)), new(0.10588707180971013d, new GammaParticle(89954.0, 0.01378)), new(0.1712828725488679d, new GammaParticle(93347.0, 0.01328)), new(0.06094836472806429d, new GammaParticle(105566.0, 0.01174)), new(0.08148796364142194d, new GammaParticle(106894.0, 0.0116)), new(0.020539598913357663d, new GammaParticle(108580.0, 0.01142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    