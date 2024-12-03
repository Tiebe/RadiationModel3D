using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium123m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium123m";
        public override double halfLife { get; } = 47.4d;
        public override double atomicWeight { get; } = 122.91079d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin123()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.45d, new GammaParticle(125760.0, 0.00986)), new(0.0008774999999999999d, new GammaParticle(896500.0, 0.00138)), new(0.0011250000000000001d, new GammaParticle(1170000.0, 0.00106)), new(0.00020250000000000002d, new GammaParticle(2469000.0, 0.0005)), new(0.00046125d, new GammaParticle(2598000.0, 0.00048)), new(0.000585d, new GammaParticle(2695000.0, 0.00046)), new(0.0006525d, new GammaParticle(3064000.0, 0.0004)), new(0.00042750000000000004d, new GammaParticle(3103000.0, 0.0004)), new(0.0010462499999999999d, new GammaParticle(3127000.0, 0.0004)), new(0.0003825d, new GammaParticle(3155000.0, 0.00039)), new(0.0013725d, new GammaParticle(3234000.0, 0.00038)), new(0.0091099476d, new GammaParticle(3753.0, 0.33036)), new(0.02848604752440638d, new GammaParticle(25044.0, 0.04951)), new(0.053314706203268544d, new GammaParticle(25271.0, 0.04906)), new(0.015075393711215612d, new GammaParticle(28579.0, 0.04338)), new(0.018045246272325087d, new GammaParticle(28810.0, 0.04304)), new(0.0029698525611094755d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    