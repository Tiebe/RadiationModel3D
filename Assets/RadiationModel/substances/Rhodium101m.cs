using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rhodium101m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium101m";
        public override double halfLife { get; } = 374976.0d;
        public override double atomicWeight { get; } = 100.90633d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9279999999999999d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium101()), new(0.00637d, new GammaParticle(127226.0, 0.00975)), new(0.00532d, new GammaParticle(179636.0, 0.0069)), new(0.00156d, new GammaParticle(184110.0, 0.00673)), new(0.0017699999999999999d, new GammaParticle(233740.0, 0.0053)), new(0.00202d, new GammaParticle(238270.0, 0.0052)), new(0.81d, new GammaParticle(306857.0, 0.00404)), new(0.00014099999999999998d, new GammaParticle(311400.0, 0.00398)), new(4.03e-05d, new GammaParticle(417860.0, 0.00297)), new(0.043d, new GammaParticle(545117.0, 0.00227)), new(0.039334207052232d, new GammaParticle(2737.0, 0.45299)), new(0.17447487709089657d, new GammaParticle(19150.0, 0.06474)), new(0.3310718730377544d, new GammaParticle(19279.0, 0.06431)), new(0.0889710072300423d, new GammaParticle(21736.0, 0.05704)), new(0.10338431040130913d, new GammaParticle(21875.0, 0.05668)), new(0.014413303171266852d, new GammaParticle(22072.0, 0.05617)) } },
            { 0.07200000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium101()), new(0.00241d, new GammaParticle(157410.0, 0.00788)), new(0.0032663298278d, new GammaParticle(2892.0, 0.42871)), new(0.01177841885334592d, new GammaParticle(20073.0, 0.06177)), new(0.022299164811332678d, new GammaParticle(20215.0, 0.06133)), new(0.006055639224117844d, new GammaParticle(22806.0, 0.05436)), new(0.007060875335321405d, new GammaParticle(22957.0, 0.05401)), new(0.001005236111203562d, new GammaParticle(23170.0, 0.05351)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    