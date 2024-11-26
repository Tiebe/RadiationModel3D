using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth208m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth208m";
        public override double halfLife { get; } = 0.00258d;
        public override double atomicWeight { get; } = 207.98143d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bismuth208()), new(0.00264708d, new GammaParticle(64000.0, 0.01937)), new(0.14117760000000001d, new GammaParticle(139800.0, 0.00887)), new(0.0225492d, new GammaParticle(446000.0, 0.00278)), new(0.7353000000000001d, new GammaParticle(510300.0, 0.00243)), new(0.23529599999999998d, new GammaParticle(650100.0, 0.00191)), new(0.9804d, new GammaParticle(921000.0, 0.00135)), new(0.19221803745366445d, new GammaParticle(12904.0, 0.09608)), new(0.1333467327813774d, new GammaParticle(74815.0, 0.01657)), new(0.2230997704222476d, new GammaParticle(77108.0, 0.01608)), new(0.07642038353523353d, new GammaParticle(87388.0, 0.01419)), new(0.09980502089701498d, new GammaParticle(88458.0, 0.01402)), new(0.02338463736178146d, new GammaParticle(89784.0, 0.01381)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    