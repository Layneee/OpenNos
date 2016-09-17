﻿//<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.Handler
{
    //$"in 1 {Name} - {CharacterId} {MapX} {MapY} {Direction} {(byte)Authority} {Gender} {HairStyle} {color} {Class} {GenerateEqListForPacket()} {(int)(Hp / HPLoad() * 100)} {(int)(Mp / MPLoad() * 100)} {(IsSitting ? 1 : 0)} -1 {(fairy != null ? 2 : 0)} {(fairy != null ? ((ItemInstance)fairy.ItemInstance).Item.Element : 0)} 0 {(fairy != null ? ((ItemInstance)fairy.ItemInstance).Item.Morph : 0)} 0 {(UseSp || IsVehicled ? Morph : 0)} {GenerateEqRareUpgradeForPacket()} -1 - {((GetDignityIco() == 1) ? GetReputIco() : -GetDignityIco())} {(_invisible ? 1 : 0)} {(UseSp ? MorphUpgrade : 0)} 0 {(UseSp ? MorphUpgrade2 : 0)} {Level} 0 {ArenaWinner} {Compliment} {Size} {HeroLevel}"
    [Header("in")]
    public class InPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public InType InType { get; set; }

        [PacketIndex(1, HasStringOffset = true)]
        public string Name { get; set; }

        [PacketIndex(2)]
        public long Id { get; set; }

        [PacketIndex(3)]
        public short MapX { get; set; }

        [PacketIndex(4)]
        public short MapY { get; set; }

        [PacketIndex(5)]
        public byte Direction { get; set; }

        [PacketIndex(6)]
        public byte Authority { get; set; }

        [PacketIndex(7)]
        public byte Gender { get; set; }

        [PacketIndex(8)]
        public byte Hairstyle { get; set; }

        [PacketIndex(9)]
        public byte Color { get; set; }

        [PacketIndex(10)]
        public ClassType Class { get; set; }


        #endregion
    }
}