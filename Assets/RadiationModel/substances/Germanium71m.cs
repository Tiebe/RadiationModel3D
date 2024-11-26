using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium71m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium71m";
        public override double halfLife { get; } = 0.02022d;
        public override double atomicWeight { get; } = 70.92517d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium71()), new(0.0048d, new GammaParticle(23438.0, 0.0529)), new(0.9162d, new GammaParticle(174956.0, 0.00709)), new(0.018011014902719998d, new GammaParticle(1221.0, 1.01543)), new(0.1431282766246882d, new GammaParticle(9856.0, 0.1258)), new(0.2779729590691167d, new GammaParticle(9887.0, 0.1254)), new(0.06217629791212833d, new GammaParticle(11026.0, 0.11245)), new(0.06354417646619515d, new GammaParticle(11038.0, 0.11232)), new(0.0013678785540668231d, new GammaParticle(11099.0, 0.11171)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    