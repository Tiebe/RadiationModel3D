using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Iridium189m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium189m";
        public override double halfLife { get; } = 0.0133d;
        public override double atomicWeight { get; } = 188.95912d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium189()), new(0.012d, new GammaParticle(71690.0, 0.01729)), new(0.11199999999999999d, new GammaParticle(113820.0, 0.01089)), new(0.248d, new GammaParticle(186700.0, 0.00664)), new(0.04d, new GammaParticle(258370.0, 0.0048)), new(0.41200000000000003d, new GammaParticle(300510.0, 0.00413)), new(0.4016138908936d, new GammaParticle(10728.0, 0.11557)), new(0.14117016560753395d, new GammaParticle(63287.0, 0.01959)), new(0.24226903313460435d, new GammaParticle(64896.0, 0.01911)), new(0.0812903055790036d, new GammaParticle(73637.0, 0.01684)), new(0.10429546205786161d, new GammaParticle(74510.0, 0.01664)), new(0.023005156478858018d, new GammaParticle(75576.0, 0.01641)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    